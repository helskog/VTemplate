#!/bin/bash
set -e

REPO_NAME="$(basename "$(pwd)")"
GITHUB_USER="$(gh api user --jq .login)"

echo "Initializing Git repo"
git init
git checkout -b dev
git add .
git commit -m "Initial commit"

echo "Creating GitHub repo"
gh repo create "$REPO_NAME" --private --source=. --remote=origin --push

echo "Pushing dev branch"
git push -u origin dev

echo "Creating empty release branch"
git checkout --orphan release

echo "Switching back to dev branch"
git checkout dev

echo "Adding GitHub Actions secret..."
gh secret set THUNDERSTORE_SECRET --repo "$GITHUB_USER/$REPO_NAME" --body "$DEPLOY_TS_SECRET"

echo "Finished all actions!"

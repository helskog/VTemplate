#!/bin/bash

set -e

echo "Initializing Git repo..."

git init
git add .
git commit -m "Initial commit"

echo "Creating GitHub repo..."

gh repo create "$(basename "$(pwd)")" --private --source=. --remote=origin --push

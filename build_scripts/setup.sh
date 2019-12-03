#/usr/bin/env/bash
echo "[${date}] Running setup script for Cloud Build"
echo "[${date}] Current work directory is: ${pwd}"
ls
# create directory for code
mkdir app
ls

echo "[${date}] Head branch: $1"
echo "[${date}] Base branch: $2"
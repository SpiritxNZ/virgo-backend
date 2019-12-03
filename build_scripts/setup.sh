#/usr/bin/env/bash
echo "[$(date)] Running setup script for Cloud Build"
echo "[$(date)] Current work directory is: $(pwd)"
# create directory for code
mkdir -p app
cd app
echo "[$(date)] Changed work directory to: $(pwd)"
#!/usr/bin/env bash
mkdir 0-new_project

cd 0-new_project || exit

dotnet new console

echo "The template \"Console Application\" was created successfully."

dotnet restore

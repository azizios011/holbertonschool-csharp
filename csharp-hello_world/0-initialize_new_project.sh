#!/bin/bash
mkdir 0-new_project
cd 0-new_project
dotnet new console
echo "The template \"Console Application\" was created successfully."
dotnet restore

#!/usr/bin/env bash

# Create a directory for the new project
mkdir 1-new_project

# Navigate into the new project directory
cd 1-new_project || exit

# Initialize a new C# console application using dotnet
dotnet new console

# Display a success message
echo "The template \"Console Application\" was created successfully."

# Run 'dotnet restore' to restore project dependencies
dotnet restore

# Build the project
dotnet build

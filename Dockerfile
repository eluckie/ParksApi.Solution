# Set the base image to .NET 7 SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Set the working directory to /app
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY app/*.csproj .
RUN dotnet restore

# Copy the remaining source code
COPY app .

# Build the application
RUN dotnet publish -c Release -o /publish

# Create the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "ParksApi.dll"]
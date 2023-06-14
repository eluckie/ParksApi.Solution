# Set the base image to .NET 7 SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0-bullseye-slim-amd64 AS build

ARG TARGETARCH
ARG TARGETOS

RUN arch=$TARGETARCH \
    && if [ "$arch" = "amd64" ]; then arch="x64"; fi \
    && echo $TARGETOS-$arch > /tmp/rid

# Set the working directory to /app
WORKDIR /app

# Copy the project file(s) and restore dependencies
COPY *.csproj ./
RUN dotnet restore -r $(cat /tmp/rid)

# Copy the remaining source code
COPY . .

# Build the application
RUN dotnet publish -c Release -o /app -r $(cat /tmp/rid) --self-contained false --no-restore

# Create the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "ParksApi.dll"]
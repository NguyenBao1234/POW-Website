# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and restore dependencies
COPY *.sln ./
COPY POW_Website/*.csproj POW_Website/
RUN dotnet restore

# Copy entire source code and publish
COPY . ./
WORKDIR /app/POW_Website
RUN dotnet publish -c Release -o /app/out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Run the web app
ENTRYPOINT ["dotnet", "POW_Website.dll"]

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and project files
COPY *.sln .
COPY VoteCounter/*.csproj ./VoteCounter/

# Restore dependencies
RUN dotnet restore VoteCounter/VoteCounter.csproj

# Copy everything and build
COPY . .
RUN dotnet publish VoteCounter/VoteCounter.csproj -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "VoteCounter.dll"]

# ============================
# Build Stage
# ============================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies separately for faster builds
COPY *.sln .
    COPY VoteCounter/*.csproj ./VoteCounter/
    RUN dotnet restore VoteCounter/VoteCounter.csproj

    # Copy the rest of the code and publish
    COPY . .
    WORKDIR /app/VoteCounter
    RUN dotnet publish -c Release -o /app/out

    # ============================
    # Runtime Stage
    # ============================
    FROM mcr.microsoft.com/dotnet/aspnet:8.0
    WORKDIR /app
    COPY --from=build /app/out ./

    # Expose the port Render will map dynamically
    EXPOSE 5000

    ENTRYPOINT ["dotnet", "VoteCounter.dll"]

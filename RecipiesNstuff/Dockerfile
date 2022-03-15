#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 50000
EXPOSE 60000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/RecipiesNstuff/RecipiesNstuff.csproj", "RecipiesNstuff/"]
RUN dotnet restore "RecipiesNstuff/RecipiesNstuff.csproj"
COPY . .
WORKDIR "/src/RecipiesNstuff"
RUN dotnet build "RecipiesNstuff.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RecipiesNstuff.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RecipiesNstuff.dll"]
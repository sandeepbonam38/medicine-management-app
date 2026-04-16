# ---------- BUILD STAGE ----------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy solution file
COPY MedicineManagement.sln .

# Copy each project individually (important for layer caching)
COPY MedicineManagement.Domain/. ./MedicineManagement.Domain/
COPY MedicineManagement.Application/. ./MedicineManagement.Application/
COPY MedicineManagement.Infrastructure/. ./MedicineManagement.Infrastructure/
COPY medicineAPI/. ./medicineAPI/

# Restore dependencies using solution
RUN dotnet restore "MedicineManagement.sln"

# Publish API project
RUN dotnet publish "medicineAPI/medicineAPI.csproj" -c Release -o /app/out --no-restore

# ---------- RUNTIME STAGE ----------
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app

# Copy published output
COPY --from=build /app/out .

# Render uses port 10000 by default
EXPOSE 10000

ENV ASPNETCORE_URLS=http://+:10000

# Run API
ENTRYPOINT ["dotnet", "medicineAPI.dll"]

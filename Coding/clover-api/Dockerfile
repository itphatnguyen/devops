FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /app

COPY  ./develop/ /app/
EXPOSE 50001

ENTRYPOINT [ "dotnet","Clover.AppServices.Api.dll" ]


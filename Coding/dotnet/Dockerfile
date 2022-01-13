FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

COPY ./bin/Release/net6.0/publish/*.* /app/
EXPOSE 8085

ENTRYPOINT [ "dotnet","dotnet.dll" ]
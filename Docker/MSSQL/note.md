# MSSQL 
- Image : `mcr.microsoft.com/mssql/server:2017-latest`
- User sa: sa
- Port 1433
- database: `/var/opt/mssql` 
- Biến moi trường `-e SA_PASSWORD=123`
- Biến moi truong `-e ACCEPT_EULA=y`

- run image `docker run --name sqlserver -p 1433:1433 -v mssql:/var/opt/mssql -e SA_PASSWORD=P@ssw0rd -e ACCEPT_EULA=y efbfdfd84467`
# SQL command SQLCMD
- sql cmd trong container (/opt/mssql-tools/bin/sqlcmd)
- `sqlcmd -S host -U user -P password`

# Tạo Volume để luu trử du dieu sql

`docker volume create mssql`

# Tạo ổ đĩa có tên mssql và mount cái volume sang ổ local
docker volume create --opt device=/home/mydata --opt type=none --opt o=bind  mssql
docker volume create --opt device=Users/admin/Documents/VolumeMount/mssql --opt type=none --opt o=bind  mssql
# Gán ổ đĩa vào container tại (/home/sites) - tức là mount thư mục trong container ra volume 
docker run -it -v mssql:/home/sites ubuntu


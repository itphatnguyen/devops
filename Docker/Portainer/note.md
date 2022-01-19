# Portainer 

-  Tạo volume cho portainer: 
`docker volume create --opt device=Users/admin/Documents/VolumeMount/portainer --opt type=none --opt o=bind  portainer`


docker run -d -p 8000:8000 -p 9000:9000 --name=portainer --restart=always -v /var/run/docker.sock:/var/run/docker.sock -v portainer:/data 580c0e4e98b0

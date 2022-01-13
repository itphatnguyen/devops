#! /bin/bash
cd /Users/admin/Documents/Devops/DockerSwarm/master
exec  vagrant halt
&
cd /Users/admin/Documents/Devops/DockerSwarm/node1
exec  vagrant halt
&
cd /Users/admin/Documents/Devops/DockerSwarm/node2
exec  vagrant halt
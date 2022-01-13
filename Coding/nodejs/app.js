var http = require("http");
var sleep = require("system-sleep");
var os = require("os");

http
  .createServer((req, res) => {    
    res.writeHead(200, { "Content-Type": "text/plain" });
    res.end("Swarm service (Node app), hostname: " + os.hostname);
  })
  .listen(8085);

console.log("Node app run on port 8085"+ os.hostname);

// =====================================
// index.js
// =====================================
// Start web server and handle requests
// and responses
// =====================================

const http = require('http');

const routes = require('./routes');
const router = require('./router');

// ===============================
// Handle any uncaught exceptions 
// ===============================

process.on('uncaughtException', function(err) {
    // handle the error safely
    console.log('uncaughtException');
    console.error(err.stack);
    console.log(err);
});

// ======================================
// Start web server and pass all inbound 
// requests to the routes module        
// ====================================== 

const server = http.createServer(async (req, res) => {
    await router(req, res, routes);
});

server.listen(3030, () => {
    console.log('Server is listening on port 3030');
});
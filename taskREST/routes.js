// ================================
// routes.js
// ================================
// Defines valid Routes. Each route 
// has three parameters:
// - method : REST operation
// - path: Valid URL for operation
// - handler: Controller module 
// ================================

const taskController = require('./controllers/taskController');

const routes = [
    {
        method: 'POST',
        path: '/task/save',
        handler: taskController.create.bind(taskController)
    },
    {
        method: 'GET',
        path: '/task/get',
        handler: taskController.index.bind(taskController)
    }
];

module.exports = routes;
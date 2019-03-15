// =======================================
// router.js
// =======================================
// This module has three functions:
// - establish if operation is valid i.e
//   it has a matching entry in routes
// - For GET, extract data from req.body
// - Pass control to route handling module
// =======================================

const { parse } = require('querystring');
const helpers = require('./common/helpers');

module.exports = async (req, res, routes) => {

    // =====================================
    // Find a matching route
    // =====================================
    // Walk through routes object parameter. 
    // Error unless there is a match on both
    // method and path.
    // =====================================
 
    const route = routes.find((route) => {        
        const methodMatch = route.method === req.method;
        
        if (methodMatch) {
            pathMatch = route.path === req.url;         
            return pathMatch && methodMatch;
        } 
        else return false;          

    });

    // ==================================
    // Extract request body from req.body
    // ==================================
    
    if (route) {
        let body = null;
        if (req.method === 'POST') {
            body = await getPostData(req);
        }
        return route.handler(req, res, body);
    }
    else {
        return helpers.error(res, 'Endpoint not found', 404);
    }
};

// =====================================
// Extract posted data from request body
// @param - req
// @returns - {Promise<any>}
// =====================================

function getPostData(req) {
    return new Promise((resolve, reject) => {
       try {
           let body = '';
           req.on('data', chunk => {
               body += chunk.toString(); // convert Buffer to string
           });

           req.on('end', () => {
               //resolve(parse(body));
               resolve(body);
           });
       }
       catch (e) {
           reject(e);
       }
    });
}
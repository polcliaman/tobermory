// ================================
// helpers.js
// ================================
// Handles output back to client
// ================================

// ============================================
// This will be called with there are errors
// as per the schema definition. Default values
// set if none are provided for the error 
// message or code
// ============================================

module.exports.validationError = (res, error = 'Data provided is not valid') => {
    addHeaders(res);

    res.statusCode = 422;

    res.end(JSON.stringify({
        status: 'fail',
            error
    }, null, 3));
};

// ==========================================
// Handles all errors apart from schema
// validation. Default values set if none are 
// provided for the error message or code
// ==========================================

module.exports.error = (res, error = 'An unknown error occurred', statusCode = 500) => {
    addHeaders(res);

    res.statusCode = statusCode;

    res.end(JSON.stringify({
        status: 'fail',
        error
    }, null, 3));
};

// ==========================================
// Handles successful DB interactions. Returns
// data generated from POST or GET in res.
// ==========================================

module.exports.success = (res, data = null) => {
    addHeaders(res);

    res.statusCode = 200;

    res.end(JSON.stringify({
        status: 'success',
        data
    }, null, 3));
};

// ============================
// Add header to all responses
// ============================

const addHeaders = (res) => {
    return res.setHeader('Content-Type', 'application/json');
}
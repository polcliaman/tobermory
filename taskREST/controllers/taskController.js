// ================================
// taskController.js
// ================================
// Handles all processing connected
// with validating and parsing data
// before interacting with MongoDB
// ================================

const mongoose = require('mongoose');
const Task = require('./../models/Task');
const helpers = require('./../common/helpers');

class TaskController {

    // ================================================
    // create (POST)
    // ================================================
    // - Parse data from postData
    // - create new entry in Mongo via task model js
    // - handle any errors
    // ================================================
    
    async create (req, res, postData) {

        postData = JSON.parse(postData);

        let { taskTitle, taskDetails } = postData;

        try {
            const task = await Task.create({ taskTitle, taskDetails });
           
            return helpers.success(res, task.toClient());
        }
        catch (error) {
            if (error.name === 'ValidationError') {
                return helpers.validationError(res, error);
            }
            else
            {
                return helpers.error(res);
            }
        }
    }

    // =======================================
    // index (GET)
    // =======================================
    // - runs query in Mongo via task model js
    // - handle any errors
    // =======================================

    async index (req, res) {

        try {
            const selectParams = {
                taskTitle: 1,
                taskDetails: 1
            };

            const tasks = await Task.getAll({}, selectParams);

            return helpers.success(res, tasks);
        }
        catch (error) {
            return helpers.error(res, error);
        }
    }
   
}

module.exports = new TaskController();

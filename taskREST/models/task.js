// =====================================
// tasks.js
// =====================================
// Model for task document type. This is
// used to define the schema and the 
// DB interactions with MongoDB
// =====================================

const mongoose = require('mongoose');
const Schema = mongoose.Schema;
const MongoDB = require('./MongoDB');

// ===============================
// Task Schema 
// ===============================
// Definition of schema used to
// hold a task document in MongoDB
// ===============================

const taskSchema = new Schema({
    // Title of the task
    taskTitle: {
        type: String,
        required: true
    },

    // Details of the task
    taskDetails: {
        type: String,
        required: true
    }

}, { timestamps: true });

// ====================================================
// This instance method simply deletes some fields from
// being displayed back to the user. It does not delete
// them from the database - simply the in memory object
// ====================================================

taskSchema.method('toClient', function () {
    const task = this.toObject();

    delete task.__v;
    delete task.deletedAt;
    delete task.createdAt;
    delete task.updatedAt; 

    return task;
});

// ================================
// taskmodel
// ================================
// This is the model of the MongoDB
// used in this api
// ================================

const taskModel = MongoDB.model('tasks', taskSchema);

// ======================================
// Task class
// ======================================
// Contains 2 static methods
// - create: Commit new record to MongoDB
// - getAll: Get all task entries from DB
// ======================================

class Task {

// ===============================================
// create (POST)
// ===============================================
// DB interaction wrapped in a promise. Validation
// is run against schema (above) using built-in
// MongoDB validation function - validateSync().
// If valid a save (commit) is run. Result will
// either be:
// resolved promise - no errors, data committed
// rejected promise - schema or db errors
// ===============================================

    static create (data) {
        const newTask = taskModel(data);

        return new Promise((resolve, reject) => {
            const error = newTask.validateSync();
            if (error) {
                reject(error);
            }

            newTask.save((err, obj) => {
                if (obj) {
                    resolve(obj);
                }
                else {
                    reject(err);
                }
            });
        });
    }

// ===============================================
// getAll (GET)
// ===============================================
// DB interaction wrapped in a promise. Has 2 
// parts:
// - Define fields to return (get _id by default)
// - Execute query (lean to remove Mongo bits)
// End of function will be either:
// - resolved promise: no errors, data returned
// - rejected promise: db errors
// ================================================

    static getAll (conditions, selectParams) {
        return new Promise((resolve, reject) => {
            const query = taskModel.find(conditions);

            if (selectParams) {             
                query.select(selectParams);            
            }

            query.lean().exec((err, docs) => {
                if (docs) {
                    console.log(docs);
                    resolve(docs);
                }
                else {
                    reject(err);
                }
            });
        });
    }    
}

module.exports = Task;
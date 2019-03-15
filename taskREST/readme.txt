Requirements
~~~~~~~~~~~~

1. Node.js
2. Access to MongoDB cluster 

How to run
~~~~~~~~~~

1. Run npm install to create modules folder
2. Modify the connection string config.js
3. Run "node index.js"

Project Structure
~~~~~~~~~~~~~~~~~

1. index.js - Bootstraps the application
2. config.js - Database and other configurations
3. router.js - Custom router for routing endpoints
4. routes.js - List of routes (api endpoints in the project)
5. common - Helper used in a couple of modules
6. models - Project's models
7. controllers - Project's controllers

Request Requirements
~~~~~~~~~~~~~~~~~~~~

1. API is JSON based
2. All requests should have 'Content-Type: application/json' header set
3. Request body for POST and PUT should be in JSON format.

** This is a very simply API. Only one data document, a couple of fields and two basic REST operations. Could add more. This is just to see the basics in action **

Model
~~~~~~
Task:
{
    taskTitle: ""                // Title of the task
    taskDetail: ""               // Details of the task
}

Example Requests and Responses
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

POST localhost:PORT/task/save
Body:
{
    "taskTitle": "Get a life",
    "taskDetails": "Climb a mountain and smoke a kipper for dinner"
}

Response:
{
    "status": "success",
    "data": {
        "_id": "5c8bb1694d625c484459ebed",
        "taskTitle": "Get a life",
        "taskDetails": "Climb a mountain and smoke a kipper for dinner"
    }
}

GET localhost:PORT/task/get
Response:
{
    "status": "success",
    "data": [
        {
            "_id": "5c8a6959c1e75a2f2c7c36e1",
            "taskTitle": "Understand eveything",
            "taskDetails": "Become an expert on Quantum mechanics by tomorrow. This afternoon if possible."
        },
        {
            "_id": "5c8a69cfc1e75a2f2c7c36e2",
            "taskTitle": "Get a life",
            "taskDetails": "Climb a mountain and smoke a kipper for dinner"
        }
    ]
}

const ApiInfoModule = (() => {

    const driverCalls = [
        {
            title: "Get Drivers",
            description: 
            `
                Returns an array of objects containing info about each driver in the database. \n
                Example: axios.get(http://localhost:5034/api/Driver/) => return [{driver1}, {driver2}, {driver3}...]
            `,
            url: "http://localhost:5034/api/Driver"
        },
        {
            title: "Get Driver by Id",
            description: 
            `
                Returns an object containing info about a driver with a specified id. \n 
                Example: axios.post(http://localhost:5034/api/Driver/{id}) => return {driverWithId}
            `,
            url: "http://localhost:5034/api/Driver/"
        },
        {
            title: "Delete Drivers",
            description: 
            `
                Deletes an entity from the driver-table with specified {id}. \n
                Example: axios.delete(http://localhost:5034/api/Driver/{id})
            `,
            url: "http://localhost:5034/api/Driver/{id}"
        },
        {
            title: "Post Driver",
            description: 
            `
                Adds a new entity to the drivers-table, the axios call takes 2 arguments here (controller, object). \n 
                Example: axios.post(http://localhost:5034/api/Driver/, {newDriver})
            `,
            url: "http://localhost:5034/api/Driver/"
        },
        {
            title: "Update Driver",
            description: 
            `
                Updates entity in driver-table, the axios call takes 2 arguments here (controller, driverToUpdate) \n 
                Example: axios.post(http://localhost:5034/api/Driver/, {driverToUpdate})
            `,
            url: "http://localhost:5034/api/Driver/"
        }
    ];
    
    const raceCalls = [
        {
            title: "Get Races",
            description: 
            `
                Returns an array of objects containing info about each race in the database. \n
                Example: axios.get(http://localhost:5034/api/Races/) => return [{race1}, {race2}, {race3}...]
            `,
            url: "http://localhost:5034/api/Races/"
        },
        {
            title: "Get Race by Id",
            description: 
            `
                Returns an object containing info about a race with a specific id. \n 
                Example: axios.post(http://localhost:5034/api/Races/{id}) => return {RaceWithId}
            `,
            url: "http://localhost:5034/api/Races/"
        },
        {
            title: "Delete Race",
            description: 
            `
                Deletes an entity from the race-table with specified id. \n
                Example: axios.delete(http://localhost:5034/api/Driver/{id})
            `,
            url: "http://localhost:5034/api/Driver/{id}"
        },
        {
            title: "Post Race",
            description: 
            `
                Adds a new entity to the race-table, the axios call takes 2 arguments here (controller, object). \n 
                Example: axios.post(http://localhost:5034/api/Race/, {newDriver})
            `,
            url: "http://localhost:5034/api/Driver/"
        },
        {
            title: "Update Race",
            description: 
            `
                Updates entity in race-table, the axios call takes 2 arguments here (controller, raceToUpdate) \n 
                Example: axios.post(http://localhost:5034/api/Race/, {raceToUpdate})
            `,
            url: "http://localhost:5034/api/Race/"
        }
    ]
    
    const uploadImageCall = {
        title: "Upload Image",
        description: 
        `
            Uploads a new imagefile to the API. Here a custom axios call is needed.
            Example: \n
                await axios({ \n
                    url: http://localhost:5034/api/ImageUpload, \n
                    method: "POST", \n
                    data: {FormDataHere}, \n
                    headers: {"Content-Type": "multipart/form-data"} \n
                }); \n
            Images can be accessed with url. \n
            Example: http://localhost:5034/api/images/{image_name}/
        `,
        url: "http://localhost:5034/api/ImageUpload"
    }

    const getDriverCalls = () => structuredClone(driverCalls);

    const getRaceCalls = () => structuredClone(raceCalls);

    const getUploadImageCall = () => structuredClone(uploadImageCall);

    return {
        getDriverCalls,
        getRaceCalls,
        getUploadImageCall
    }
})();

export default ApiInfoModule;
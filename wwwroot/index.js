import ApiInfoModule from "./modules/ApiInfoModule.js";

const driverInfo = document.querySelector("#driverInfo");
const raceInfo = document.querySelector("#raceInfo");
const uploadImageInfo = document.querySelector("#uploadImageInfo");

const driverButtons = document.getElementsByClassName("driverButton");
const raceButtons = document.getElementsByClassName("raceButton");
const uploadImageButtons = document.getElementsByClassName("uploadImageButton");

const driverCalls = ApiInfoModule.getDriverCalls();
const raceCalls = ApiInfoModule.getRaceCalls();
const uploadImageCalls = ApiInfoModule.getUploadImageCall();

driverCalls.forEach( (info) => {
    driverInfo.innerHTML += `
        <div class="infoArticle bg-dark p-5 m-5 rounded w-100">
            <h3 class="display-3 text-light border-bottom border-1 border-light">${info.title}<h3/>
            <p class="description text-light mt-3 mb-3">${info.description}<p/>
            <p class="url text-light border border-light border-1 p-3 mt-5 rounded">${info.url}<p/>
        <div/>
    `;
});

raceCalls.forEach( (info) => {
    raceInfo.innerHTML += `
        <div class="infoArticle bg-dark p-5 m-5 rounded w-100">
            <h3 class="display-3 text-light border-bottom border-1 border-light">${info.title}<h3/>
            <p class="description text-light mt-3 mb-3">${info.description}<p/>
            <p class="url text-light border border-light border-1 p-3 mt-5 rounded">${info.url}<p/>
        <div/>
    `;
});

uploadImageInfo.innerHTML = `
    <div class="infoArticle bg-dark p-5 mb-5 rounded w-100">
        <h3 class="display-3 text-light border-bottom border-1 border-light">${uploadImageCalls.title}<h3/>
        <p class="description text-light mt-3 mb-3">${uploadImageCalls.description}<p/>
        <p class="url text-light border border-light border-1 p-3 mt-5 rounded">${uploadImageCalls.url}<p/>
    <div/>
`;

for (let i = 0; i < driverButtons.length; i ++) {
    driverButtons[i].addEventListener('click', () => {
        window.location.hash = '#driverSection';
    });
};

for (let i = 0; i < raceButtons.length; i ++) {
    raceButtons[i].addEventListener('click', () => {
        window.location.hash = '#raceSection';
    });
};

for (let i = 0; i < uploadImageButtons.length; i ++) {
    uploadImageButtons[i].addEventListener('click', () => {
        window.location.hash = '#uploadImageSection';
    });
}

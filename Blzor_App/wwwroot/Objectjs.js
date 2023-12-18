// a mehod that does not accept any parameter or return any value
function displayAlert() {
    alert('I am a  method from JavaScript');
}

// a method that acccepts parameters and return a value
function concatinate(str1, str2) {
    return `${str1} ${str2}`;
}

// a method that performs an Async Operation
//function getProducts() {
//    return new Promise((resolve, reject) => {
//        let xhr = new XMLHttpRequest();

//        xhr.onload = function () {
//            if (xhr.status === 200) {
//                resolve(xhr.response);
//            }
//        };

//        xhr.onerror = function () {
//            reject("Some Error Occured");
//        };

//        xhr.open("GET", "https://apiapptrainingnewapp.azurewebsites.net/api/Products");
//        xhr.send();
//    });
//}
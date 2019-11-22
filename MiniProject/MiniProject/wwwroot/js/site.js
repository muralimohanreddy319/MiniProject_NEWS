// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function displayForm(c) {
    if (c.value == "yes") {

        document.getElementById("notvisited").style.visibility = 'visible';
        document.getElementById("visited").style.visibility = 'hidden';
    }
    else if (c.value == "no") {
        document.getElementById("notvisited").style.visibility = 'hidden';

        document.getElementById("visited").style.visibility = 'visible';
    }
    else {
    } 
}

$("#btn1").click(function () {
    document.getElementById("notvisited").style.visibility = 'visible';
    document.getElementById("visited").style.visibility = 'hidden';
});

function loadFunction() {
    var dt = new Date();
    console.log(dt);
    document.getElementById("datetime").innerHTML = dt.toLocaleString();
}
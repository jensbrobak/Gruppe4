$(document).ready(function () {

    //this makes a popup window with a alert
    //alert("Hello there!");

    console.log("Hello!");


    //this is without jQuery
    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;

    //var button = document.getElementById("buyButton");
    ////button.addEventListener("click", function () {
    ////    console.log("Buying Item");
    ////});

    //var productInfo = document.getElementsByClassName("product-props");
    //var listItems = productInfo.item[0].children;

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });

    var productInfo = $(".product-props li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.fadeToggle(500);
    });



}); 

var storage = window.localStorage;

var basket = {};
$(document).ready(function () {

    $("#Save").click(OnStoreClick);

   

});

function OnStoreClick(event) {

    alert("Function loaded");
    var umbrella = document.getElementById("UmbrellaDD").value;
    var alligator = document.getElementById("AlligatorDD").value;
    var FlySwatter = document.getElementById("FlySwatterDD").value;
    alert("vars loaded");

    basket["Umbrella"] = umbrella;
    basket["Alligator"] = alligator;
    basket["FlySwatter"] = FlySwatter;
    alert("basket filled with stuffs");

    var json = JSON.stringify(basket);
    alert("json:" + json);
    storage.setItem("Basket", json);
    alert("stored: " + umbrella + " " + alligator + " " + FlySwatter);
}
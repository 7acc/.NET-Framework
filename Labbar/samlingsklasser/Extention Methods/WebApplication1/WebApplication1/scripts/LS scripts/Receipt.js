var basket = {};
var storage = window.localStorage;
$(document).ready(function () {

    alert("JS loaded");
    LoadBasket();
});


function LoadBasket() {
    alert("funktion loaded");
    
    var jsonBasket = storage.getItem("Basket");
   
    alert("in JSON basket" + jsonBasket);
    form1.HF.value = jsonBasket;
    alert(form1.HF.value)

    document.getElementById("Load").click();
    alert("button has been clicked");
   
}

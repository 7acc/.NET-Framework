var storage = window.localStorage;

$(document).ready(function () {

    $("#Button1").click(OnStoreClick);

    $("#Button2").click(Restore);

});

function OnStoreClick(event) {

    var key = "Name"

    var value = $("#T1").val();

    storage.setItem(key, value);

    var key2 = "NR"
    var value2 = $("#T2").val();

    storage.setItem(key2, value2);

    alert("Storage event fired: " + value + ", " + value2);



}

function Restore(event) {

    if (document.getElementById("T1").value == "" && document.getElementById("T2").value == "") {
        alert("restore fired")

        var Name = (storage.getItem("Name"));
        var NR = (storage.getItem("NR"));

        document.getElementById("T1").value = Name
        document.getElementById("T2").value = NR

        alert(Name + NR + "Restored!");
    }



}
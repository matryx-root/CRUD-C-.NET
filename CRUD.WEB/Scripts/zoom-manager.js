// zoom-manager.js
document.addEventListener("DOMContentLoaded", function () {
    // Variable para mantener el nivel de zoom
    var currentZoom = 1;

    // Función para ajustar el nivel de zoom de la página
    function setZoom(factor) {
        document.body.style.zoom = factor;
        currentZoom = factor;
    }

    // Obtén el nivel de zoom actual (si lo hubiera)
    if (localStorage.getItem("zoom")) {
        currentZoom = parseFloat(localStorage.getItem("zoom"));
        setZoom(currentZoom);
    }

    // Añade manejadores de eventos para los botones de zoom
    var btnZoomIn = document.getElementById("btnZoomIn");
    var btnZoomOut = document.getElementById("btnZoomOut");

    btnZoomIn.addEventListener("click", function () {
        currentZoom *= 1.1;
        setZoom(currentZoom);
        localStorage.setItem("zoom", currentZoom.toString()); // Almacena el nivel de zoom en localStorage
    });

    btnZoomOut.addEventListener("click", function () {
        currentZoom *= 0.9;
        setZoom(currentZoom);
        localStorage.setItem("zoom", currentZoom.toString()); // Almacena el nivel de zoom en localStorage
    });
});

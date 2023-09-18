// zoom.js
document.addEventListener("DOMContentLoaded", function () {
    // Obtén los botones de zoom
    var btnZoomIn = document.getElementById("btnZoomIn");
    var btnZoomOut = document.getElementById("btnZoomOut");

    // Agrega manejadores de eventos para los botones de zoom
    btnZoomIn.addEventListener("click", function () {
        zoom(1.1); // Aumenta el zoom en un 10%
    });

    btnZoomOut.addEventListener("click", function () {
        zoom(0.9); // Reduce el zoom en un 10%
    });

    // Función para ajustar el nivel de zoom de la página
    function zoom(factor) {
        var currentZoom = document.body.style.zoom || 1;
        document.body.style.zoom = parseFloat(currentZoom) * factor;
    }
});

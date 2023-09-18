$(document).ready(function () {
    // Cuando se hace clic en el botón "Sí" del modal de confirmación
    $('#btnConfirmarSi').click(function () {
        // Ocultar el modal de confirmación
        $('#confirmModal').modal('hide');

        // Graba el ticket actual
        grabarTicket();

        // Limpia los campos del formulario para crear otro ticket
        LimpiarControles();

        // Evita que el formulario se envíe automáticamente
        return false;
    });

    // Cuando se hace clic en el botón "No" del modal de confirmación
    $('#btnConfirmarNo').click(function () {
        // Ocultar el modal de confirmación
        $('#confirmModal').modal('hide');

        // Graba el ticket actual
        grabarTicket();

        // Redirige a la página ListarTickets.aspx
        window.location.href = 'ListarTickets.aspx';

        // Evita que el formulario se envíe automáticamente
        return false;
    });


    // Cuando se hace clic en el botón "Crear Ticket"
    $('#btnCrearTicket').click(function () {
        // Mostrar el modal de confirmación
        $('#confirmModal').modal('show');

        // Evitar que el formulario se envíe automáticamente
        return false;
    });
});

function grabarTicket() {
    // Coloca aquí el código para grabar el ticket actual
    // Utiliza el mismo código que está en BtnCrearTicket_Click para grabar el ticket
}

function LimpiarControles() {
    // Coloca aquí el código para limpiar los campos del formulario
    // Utiliza el mismo código que está en LimpiarControles
}

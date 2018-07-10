function showAlert(_type, _msg) {
    let _class
    let h4
    switch (type) {
        case 'error':
            _class = "alert-error"
            h4 = "Hubo un error al procesar la solicitud!"
            break
        case 'success':
            _class = "alert-success"
            h4 = "Solicitud Procesada Satisfactoriamente!"
            break
        case 'warning':
            _class = "alert-warning"
            h4 = "Advertencia!"
            break
        case 'info':
            _class = "alert-info"
            h4 = "Información!"
            break
        default:
            _class = "alert-info"
            h4 = "Información!"
            break
    }

    $('#request-msg').addClass('show')
    $('#request-msg').addClass(_class)
    $('#request-msg h4').text(h4)
    $('#request-msg p').text(_msg)
}
$(function() {
    var bands;
    $.ajax({
        url: 'rockbands.json',
        dataType: 'json',
        success: function(data) {
            bands = data;
            
            $.each(data, function(key, val) {
                $('#band').append(`<option value="${key}">${key}</option>`);    
            });
        }
    });
    
    $('#band').change(function(event) {
        var artists = bands[event.target.value];
        $('#artist').html('<option disabled selected value> -- select an option -- </option>');
        $.each(artists, function(key, val) {
            $('#artist').append(`<option value="${key}">${val.name}</option>`);
        });
    });

    $('#artist').change(function(event) {
        window.location.assign(bands[$('#band').val()][event.target.value].value);
    });
});
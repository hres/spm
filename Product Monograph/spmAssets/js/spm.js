$( document ).ready(function() {



function CallSpmHandler() {
        //$("form#productMonograph input[type=text], form#productMonograph input[type=tel], form#productMonograph input[type=email], form#productMonograph textarea, form#productMonograph select").each(function () {
        //    if( $(this).val() != "" ){
        //        met.session.save( $(this).attr('name'), $(this).val() );
        //    }
        //});
        //$("form#productMonograph input[type=radio]").each(function(){
        //    if( $(this).is(":checked") ){
        //        met.session.save( $(this).attr('name'), $(this).val() );
        //    }
        //});
        //$("form#productMonograph input[type=checkbox]").each(function(){
        //    if( $(this).is(":checked") ){
        //        if ($('input[name='+$(this).attr('name')+']').length > 1) {
        //            var valueArray = $('input[name='+$(this).attr('name')+']').map(function() { return this.value; }).get();
        //            met.session.save( $(this).attr('name'), JSON.stringify(valueArray) );
        //        } else {
        //            met.session.save( $(this).attr('name'), $(this).val() );
        //        }
        //    }
        //});
    //alert("I am here");
   
        var dataObject = $('form#productMonograph').serializeObject();
        $.ajax( {
            type: "POST",
            url: "spmHandler.ashx",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify( dataObject ),
            responseType: "json",
            success: function( response ) {
                console.log( 'Success' );               
            },
            error: function( response ){
                console.log(response);
            }
        });
        return false;
 }


function OnIndexComplete(result) {
    console.log('Success!!!!');
}
function OnFail(result) {
    console.log('Failed why');
}

$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $('input:disabled[name]', this).each(function () { a.push({ name: this.name, value: $(this).val() }); });
    $('input:hidden[name]', this).each(function () { o[this.name] = ''; });
    $.each(a, function () {
        //if (this.name == 'pointOfEntryProv') { return true; }
        if (o[this.name]) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    //o['TabletID'] = '123';
    //o['CID'] = cidString;

    $.each(o, function (index, item) {
        if ($.isArray(item)) { o[index] = o[index].join(","); }
    });
    console.log(o);
    return o;
};
});

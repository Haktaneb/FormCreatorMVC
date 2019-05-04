var checkNull = false;
var events = (function(){

  var formSave = function()
  {
    $('#formSaveBtn').click(function(){
        var form = new Forms()
        form = assignValues.getValues();
        var url = '/Home/Add'
        if(checkNull==true)
        {
            alert("İsim ve soyisim alanlarını doldurmak zorunludur.")
        }
        else
        {
            services.dataControl(form,url).done(function(result){
                window.location.href = result.newUrl;
                checkNull == false;
                assignValues.assignNull();
            })
        }       
    });
  }
    return{
        formSave:formSave
    }
})();
var assignValues = (function(){

  var getValues = function()
  {
    var form = new Forms();
        form.id = externalFunctions.createUuid();
        form.name = $('#formName').val();
        form.description = $('#formDescr').val();
        form.createdAt = $('#formCrDate').val();
        form.createdBy = externalFunctions.createUuid();
        form.creatorName = $('#formCroName').val();
        form.creatorLastName = $('#formCroLastName').val();
        if(form.creatorName == "" || form.creatorLastName == "")
        {  
            checkNull = true;
        }
        else
        {
            checkNull = false;
        }
        form.creatorAge = parseInt($('#formCroAge').val(), 10);
        return form;
  }
    var assignNull = function()
    {
        $('#formName').val(null);
        $('#formDescr').val(null);
        $('#formCrDate').val(null);
        $('#formCroName').val(null);
        $('#formCroName').val(null);
        $('#formCroLastName').val(null);
     }

    return{
        getValues:getValues,
        assignNull:assignNull
    }
})();
var externalFunctions = (function(){

    var createUuid = function() {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
          var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
          return v.toString(16);
        });
      }
      return{
        createUuid:createUuid
      }
  })();
var services = (function () {
    var dataControl = function (object, url) {
        var json = JSON.stringify(object);
        console.log(json);
        return $.ajax({
            type: "POST",
            url: url,
            data: json,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
            },
            failure: function (errMsg) {
            },error : function(errMsg)
            {
                window.location.href = "/Home/Error"
            }
        });
    };   
    return{
        dataControl: dataControl
     };
})();
$(document).ready(function () {
    events.formSave();
});
function Forms()
{
    var id = '';
    var name = '';
    var description = '';
    var createdAt = '';
    var createdBy = '';
    var creatorName = '';
    var creatorLastName = '';
    var creatorAge = 0;
}

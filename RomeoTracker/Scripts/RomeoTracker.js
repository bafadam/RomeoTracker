function UpdateDateTime(propertyname)
{
    require(["dijit/dijit"], function (dijit) {

        var datepart = dijit.byId(propertyname + '_datepart');
        var timepart = dijit.byId(propertyname + '_timepart');

        console.log(datepart);
        console.log(timepart);

        console.log(datepart.value);
        console.log(timepart.value);

        if (datepart && timepart) {
            var dateinput = dijit.byId(propertyname);

            /*
            dateinput.value = datepart.value.getFullYear() + "-" + pad(datepart.value.getMonth(),2) + "-" + pad(datepart.value.getDate(),2) + " "
                + pad(timepart.value.getHours(),2) + ":" + pad(timepart.value.getMinutes(),2) + ":" + pad(timepart.value.getSeconds(),2);


            console.log(datepart.value.getFullYear() + "-" + pad(datepart.value.getMonth(), 2) + "-" + pad(datepart.value.getDate(), 2) + " "
                + pad(timepart.value.getHours(), 2) + ":" + pad(timepart.value.getMinutes(), 2) + ":" + pad(timepart.value.getSeconds(), 2));
            */

            dateinput.value = datepart.value.getMonth() + "/" + datepart.value.getDate() + "/" + datepart.value.getYear() + " ";
            dateinput.value += timepart.value.getHours() + ":" + timepart.value.getMinutes() + ":" + timepart.value.getSeconds() + "";
        }

    });

    
}

function pad(num, size)
{
    var s = num + "";
    while (s.length < size) s = "0" + s;
    return s;
}
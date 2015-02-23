//General function that handles combining the date/time values for date/time pickers
function UpdateDateTime(propertyname)
{
    require(["dijit/dijit"], function (dijit) {

        var datepart = dijit.byId(propertyname + '_datepart');
        var timepart = dijit.byId(propertyname + '_timepart');

        if (datepart && timepart) {
            var dateinput = document.getElementById(propertyname);
            dateinput.value = datepart.value.toLocaleDateString() + " " + timepart.value.toLocaleTimeString();
        }

    });

    
}

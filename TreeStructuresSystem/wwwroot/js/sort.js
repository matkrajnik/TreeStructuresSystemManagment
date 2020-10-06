//Get from W3schools
function sortListDir(id) {
    var list, i, switching, b, shouldSwitch, dir, switchcount = 0;
    list = $('#li-' + id);
    switching = true; 
    dir = "asc";

    while (switching) {
        switching = false;
        b = list.children('ul').children('li');
        d = list.children('ul').children('li').children('p');

        for (i = 0; i < (b.length - 1); i++) {
            shouldSwitch = false;

               if (dir == "asc") {
                    if (d[i].innerHTML.toLowerCase() > d[i + 1].innerHTML.toLowerCase()) {
                        shouldSwitch = true;
                        break;
                    }
               } else if (dir == "desc") {
                    if (d[i].innerHTML.toLowerCase() < d[i + 1].innerHTML.toLowerCase()) {
                        shouldSwitch = true;
                        break;
                    }
               }
        }

        if (shouldSwitch) {
            b[i].parentNode.insertBefore(b[i + 1], b[i]);
            switching = true;
            switchcount++;
        } else {
            if (switchcount == 0 && dir == "asc") {
                dir = "desc";
                switching = true;
            }
        }
    }
}
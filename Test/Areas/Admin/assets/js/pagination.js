

function ShowOnPagination(numRow, showOnPage) {

    var firstCom = "<nav>  <ul class='pagination'>    <li class='page-item'><a class='page-link' href='#'>Previous</a></li>";

    var lastCom = "<li class='page-item'><a class='page-link' href='#'>Next</a></li>  </ul></nav>";

    var allPagi = Math.ceil(numRow / showOnPage);

    var numHtmlPage = "";
    for (var i = 0; i < allPagi; i++) {
        numHtmlPage += "<li class='page-item'><a class='page-link numbPage' href='#'>" + (i + 1) + "</a></li>";
    }


    return firstCom + numHtmlPage + lastCom;
}


function getRowShowByPagi(numRow, showOnPage, curPagi) {
    var caseIgnore = (curPagi - 1) * showOnPage;
    var indexGet = [];

    for (var i = 0; i < numRow; i++) {
        if (i >= caseIgnore) {
            if (indexGet.length >= showOnPage) {
                break;
            }
            indexGet.push(i);
        }
    }
    return indexGet;


}
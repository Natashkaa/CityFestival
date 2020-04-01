var PageCount = $('#inc').data("pagecount");

$('#inc').on('click', function () {
    let currentPage = $('#curPageNumber').text();
    if (currentPage != PageCount) {
        currentPage++;
        $('#curPageNumber').text(currentPage);
        window.location=`/Admin/GetUsers/${currentPage}`;
    }
});

$('#decr').on('click', function () {
    let currentPage = $('#curPageNumber').text();
    if (currentPage > 1) {
        currentPage--;
        $('#curPageNumber').text(currentPage);
        window.location=`/Admin/GetUsers/${currentPage}`;
    }
});
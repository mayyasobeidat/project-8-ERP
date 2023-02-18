$(document).ready(function () {
    $("#searchForm").submit(function (event) {
        event.preventDefault(); // stop the form submission from reloading the page
        var searchValue = $("#searchInput").val(); // get the search input value
        $.ajax({
            type: "GET",
            url: "/Home/Search",
            data: { search: searchValue },
            success: function (result) {
                // update the page with the search results
                $("#searchResults").html(result);
            },
            error: function () {
                // handle the error
                alert("An error occurred while processing the search request.");
            }
        });
    });
});

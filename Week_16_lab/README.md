Three things that I learned in ASP.Net are.
1. How in use bootstrap to make theme changes to webpages like        <nav class="navbar navbar-bs-expand navbar-light border-bottom box-shadow mb-3 d-flex navbar-dark bg-dark"> to change the navbar to black.
2. How to add classes to create new pages like                         <li class="nav-item px-3 <a class="nav-link text-white" asp-area="" asp-controller="Home" asp-action="Index">Home</a> </li>  
3. How to calculate tax amounts using         <div class="row form-group">
                                              <label asp-for="TaxAmount" class="col-sm-3"> Tax Amount: </label>
                                                <div class="col-sm-3">
                                              <input class="form-control" value="@ViewBag.TA.ToString("C2")" readonly>
                                              </div>
                                              <span asp-validation-for="TaxAmount"  class="col text-danger"></span>  
  
  Three things that I would like to improve in my application are.... 
  1. Adding background graphics to the all the pages to help differentiate them from one another. This would need to be add via bootstrap
  2. Add links to the products page to show the products. This would have to be added in the products page.
  3. Add a order total counter on the main page.
  
  I added in layout.cshtml A navbar the collapse the features and also changes the background color of the navbar to black as well as the centering of the heading for each page. All changed the background color on site.css.
  

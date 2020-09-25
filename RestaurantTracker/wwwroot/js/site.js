// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const buildWaiterDropDown = waiterArray => {
    let waiterOptions = ""
    waiterArray.forEach(singleWaiter => {
        waiterOptions += `<option value="${singleWaiter.id}">${singleWaiter.firstName} ${singleWaiter.lastName}</option>`
    })
  
    return `<select class="form-control valid" name = "WaiterId">${waiterOptions}</select>`
}



document.querySelector("#restaurant-dropdown").addEventListener("change", () => {

    // Get the id of the restaurant whose waiters we want to see
    console.log(event.target.value)

    // send a GET request to the controller to get the waiters at this restaurant
    fetch(`/Restaurants/Waiters/${event.target.value}`)
        .then(r => r.json())
        .then((waitersForThatRestaurant) => {
        
            const waiterDropDown = buildWaiterDropDown(waitersForThatRestaurant);

            document.querySelector("#waiter-dropdown").innerHTML = waiterDropDown;
        })
})

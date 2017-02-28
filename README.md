GroceryCo Console Application

This is an exercise to demonstrate design and implementation of a self-checkout kiosk that lets the user input their grocery list and receive a receipt of the purchased items and discounts

Notes:

Design & Limitations
  -This is clearly an example of MVC in regard to the display of the kiosk being that of the view, the controller being the logic that would display the contents of the receipt model to the view. Items are also models unto themselves.
  -It is important to note that observer patterns could be implemented with the latter advance requirements such that, in between transactions, promo's and discounts can be applied and updated for that item. The decorator pattern can be potentially used as well in order to "decorate" the receipt that would be displayed in the view.
  -Items already present in the system would be taken from a database (or CSV file) in order to be related to from the grocery list. These would be stored in another data structure for quick referencing as well (i.e dictionary vs hastable, although dictionary would suffice for simplicity and safety is not a concern)
  -loose coupling of all objects is essential

Assumptions:
  -The items that are requested are already inside the kiosk system
  -Generic items will be requested. Brand names are non-essential for the exercise.
  -

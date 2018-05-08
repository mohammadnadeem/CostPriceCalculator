Cost Price Calculation Fundamentals

A concept you are hopefully familiar with is cost…roughly defined as “the amount you pay for something”.  In Wall Street Office, we often deal with cost, but we frequently want to know the cost per unit.  We refer to the cost per unit as Cost Price.  For example, if you buy 2 shares for $1, your cost is $1 but your Cost Price of the shares is $.50.  Expanding this example further, assume you buy 2 shares for $1 and then buy another 2 shares for $1.40, you now have 4 shares that cost a total of $2.40 and the Cost Price of the 4 shares is $.60.  

To complicate matters a bit, we also frequently deal with a concept that we call the Cost Method.  In Wall Street Office, we have 5 different Cost Methods: FIFO, LIFO, Highest Cost, Lowest Cost and Weighted Average.  The Cost Method determines how the cost and Cost Price of a sale or remaining position are derived.

Consider the 4 shares that we bought above.  Suppose you sold 1 share for $.75.  Depending on the Cost Method you use, the Cost Price of the share you sold can be different.  For example, if you use the FIFO (first-in, first-out) method, the Cost Price is determined based on the shares that were “first-in” to your inventory.  Therefore, the Cost Price of the share you sold is $.50.

The FIFO, LIFO, Highest Cost and Lowest Cost methods are all very similar.  The name of the Cost Method defines the order in which purchases will be used to cover a sale.  The Weighted Average Cost Method is only slightly different.  It assumes that the weighted average cost price of the purchases is the Cost Price of the sale.  Using the same example of 4 shares bought for $2.40 above, the Cost Price of the sale of 1 share using the Weighted Average Cost Method is ((2 x $.50) + (2 x $.70)) / 4 = $.60.

At this point, it should be obvious that once the Cost Price of a sale is determined, you can easily calculate the gain or loss on the sale.  In the FIFO example, the gain was $.25 (1 share x ($.75 - $.50)).  In the Weighted Average example, the gain was $.15 (1 share x ($.75 - $.60)).



 
Now, apply these concepts and write a simple application.

Requirements
1) The application should store the following data in a collection of objects which have the following attributes:

a) PurchaseDate (date on which shares were purchased)
b) Shares (number of shares purchased)
c) Price (price represents price per share)

Load the collection with these values (you can hard code into the app)
Object 1:  a) 1/1/2005,  b)  100,  c) 10
Object 2:  a) 2/2/2005,  b)  40,  c) 12
Object 3:  a) 3/3/2005,  b)  50,  c) 11

You can order the collection in ascending order by date to make the FIFO algorithm easier to implement.

2) The application should provide a simple interface to allow the user to enter the number of shares sold, sale price and the date of the sale.  Once the user has entered the input and pressed a ‘Calculate’ button, the application should use the FIFO cost method and display the following information:

a.	The cost price of the shares sold.
b.	The gain or loss on the sale.
c.	The number of shares remaining.
d.	The cost price of the remaining shares.

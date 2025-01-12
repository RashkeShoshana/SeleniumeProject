#  Google Search Test with Selenium WebDriver

This project demonstrates a basic Selenium WebDriver test for searching the Google website and verifying the search results.

**How to Run the Test:**

1.  **Download ChromeDriver:** You will need to download the ChromeDriver executable from https://developer.chrome.com/docs/chromedriver/downloads(https://chromedriver.chromium.org/downloads) and place it in a directory accessible by your code. In the code example, the chromedriver path is set to "C:\תוכנות\chromedriver-win64". Update this path as necessary for your system.

2. **Run the Test:** You can run this test using a variety of test frameworks. The code example is written in C# using the NUnit framework. 

**Test Steps:**

1. Opens the Google Search page (https://www.google.com).
2. Verifies the page title is "Google".
3. Finds the search box element by name and enters the search term "Selenium WebDriver".
4. Submits the search query.
5. Waits for the search results to load (up to 10 seconds).
6. Verifies that search results are displayed on the page.
7. Clicks on the first search result.
8. Verifies that the new page title is not empty.
9. Navigates back to the search results page.
10. Verifies that the search term in the search box is still "Selenium WebDriver".
11. Passes the test.

**Note:**

* This is a basic example and can be extended to perform more complex testing scenarios.
* The code uses C# and the NUnit testing framework.

I hope this README file is helpful!

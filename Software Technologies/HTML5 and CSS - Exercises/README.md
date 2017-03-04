#<p align="center"> Exercises: HTML5 and CSS  <p>

Problems for exercises and homework for the [&quot;Software Technologies&quot; course @ SoftUni](https://softuni.bg/courses/software-technologies).

# I.HTML5

## 1.Welcome to HTML

Create a Web page:
- _File name:_ **welcome.html**
- _Title:_ Welcome
- _Paragraph of text:_ I am learning **HTML** and **CSS**!

## 2.Headings

Create a Web page:

- _File name_: headings.html
- _Title:_ Headings
- _Large heading:_ Headings Exercise
- _Smaller headings:_ First through Fourth

### Hints

Use &lt;h1&gt; through &lt;h5&gt; tags.

## 3.Paragraphs

Create a Web page:

- _File name_: paragraphs.html
- _Title:_ Paragraphs
- _Large heading:_ Paragraphs
- _Emphasized text:_ First, Second and Third
- _Empty line:_ Between second and third paragraph

### Hints

Use **&lt;p&gt;** , **&lt;em&gt;** and **&lt;br/&gt;** tags.

## 4.My TODO List

Create a Web page:

- _File name:_ **todo.html**
- _Title:_ TODO List
- _Large heading:_ My TODO List
- _Unordered list:_ **&lt;ul&gt;** … **&lt;/ul&gt;**
- _Three list elements:_ **&lt;li&gt;…&lt;/li&gt;**

### Hints

- Create an HTML file named **todo.html** like in the previous exercises.
- Assign the **&lt;title&gt;…&lt;title&gt;**.
- Use **&lt;ul&gt;…&lt;/ul&gt;** to create an unordered list.
- Put each of the list items in a **&lt;li&gt;…&lt;/li&gt;** tag.
- Use **&amp;amp;** for the &amp;
- Use **&amp;ndash;** for the long hyphen.

## 5.Hello HTML

Create a Web page:

- _File name:_ **hello.html**
- _Title:_ Hello HTML
- _Large heading:_ Hello HTML!
- _Paragraph of text:_ I am &lt;your name (bold)&gt;. I am from &lt;your town as link to your town&#39;s Web site&gt;.
- _Paragraph of text:_ I study &lt;specialty (italic)&gt; at &lt;link to SoftUni&gt;.

## 6.Website

Create three web pages connected to each other by local links like the screenshot below:

- _File names:_ **home.html, todo.html, hello.html**
- _Titles:_ Home, TODO List, Hello
- _Large headings:_ Home, My TODO List, Hello HTML!
- _Unordered lists: home.html and todo.html_
- _Hyperlinks:_ home.html - links to todo.html and hello.html
- _Home hyperlinks:_ todo.html and hello.html

### Hints

You can use the todo.html and hello.html pages that you have created for the previous exercises.

- Create home.html and use **&lt;ul&gt;…&lt;/ul&gt;** to create an unordered list with the links
- Use **&lt;a href=&quot;&quot;&gt;…&lt;/a&gt;** to create a hyperlink inside a **&lt;li&gt;…&lt;/li&gt;** element
- Use **href=&quot;todo.html&quot;** to connect home.html to todo.html and **href=&quot;hello.html&quot;** to connect it with hello.html.
- Create &#39;back to home&#39; links following the same logic

## 7.Fruits

Create a Web page: 

Use the fruit images given in assets:

- images\apple.png
- images\banana.png
- images\kiwi.png
- images\organge.png

### Hints

- Create a HTML page named &quot; **fruits.html**&quot; titled &quot; **Fruits**&quot;.
- Use 3 paragraphs, each holding 5 images.
- Put the images in each paragraph (row) in a sequence, one after another.

## 8.Forms

Create a Web page:

- _File name:_ **contact.html**
- _Title:_ Contact Us
- _Large heading:_ Contact Us
- _Form: holding three elements_
- _Textboxes:_ Two text boxes
- _Button:_ with text Submit

### Hints

- For the form use **&lt;form&gt;…&lt;/form&gt;**
- Inside the form place two textboxes using **&lt;input type=&quot;text&quot; /&gt;**
- Use **&lt;input type=&quot;submit&quot; value=&quot;Submit&quot; /&gt;** for the button

# II.CSS

## 9.Colors

- Use a paragraph **&lt;p&gt;…&lt;/p&gt;** to hold the text.
- Use **&lt;span**** style=&quot;…&quot;&gt;text&lt;/span&gt;** for the colored text

## 10.Colors

- Use three paragraphs **&lt;p&gt;…&lt;/p&gt;** to hold the text
- Use **&lt;p style=&quot;&quot;&gt;…&lt;/p&gt;** to style the paragraphs
- Use **&lt;span**** style=&quot;…&quot;&gt;text&lt;/span&gt;** for the colored text

## 11.Rectangles

- Use 3 nested **&lt;div&gt;** elements
- **Outside div** : blue dotted border + border-radius + padding
- **Middle div** : red dashed border + border-radius + padding
- **Inner div** : green solid border + border-radius + padding + text-align + font-size
- Use **&amp;lt;** and **&amp;gt;** to escape the **&lt;** and **&gt;** characters in the text…

## 12.Languages

- Create HTML file **langs.html**.
  - Put the text in paragraphs and **&lt;span&gt;…&lt;/span&gt;** tags.
- Create CSS file **langs.css**.
- Link the CSS file in the HTML header:
  - **&lt;link rel=&quot;…&quot; href=&quot;langs.css&quot;&gt;**
- In the **body** CSS selector in the CSS class define:
  - background:#EEE; line-height:1.5em; font-size:24pt;
- Define and use a CSS class **.lang** for styling the languages:
  - Specify border:1px #AAA, border-radius, background:#CCC, padding

## 13.Contact Us Form

Create an HTML file **contact-us-form.html** , put appropriate **title** , put &quot; **Contact Us**&quot; **heading**.
Create the **HTML code** to display the form and its fields.
In the **CSS file** put some styling to make the for look like at the above screenshot. First define the form background styling:

Style the **labels** before each form field. They stay in a **&lt;span&gt;…&lt;/span&gt;** tags.
Now style the **&lt;input&gt;…&lt;/input&gt;** and **&lt;select&gt;…&lt;/select&gt;** fields.
Finally, style the &quot; **Submit**&quot; button:
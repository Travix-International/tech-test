# Solution.md (Simple shopping cart system)


<h4>First steps and preparations.</h4>

As a first step should be collected a good team of IT workers.
On my opinion at the beginnign of project it could contain 1-2 designers, 2-3 Front-end developers, 2-3 Backend developers, 1-2 testers, Team lead or(and) project manager for communications with customer(product owner).
Customers, team Lead and project manager at first stage should orginize some meetings and conversations about future progect strict requarements  according their needs and options. 
This will be very helphul for future development and testing problem solving.
At the beginnign it's gonna be a independed module with possibility to include it in any project for inner using and salling product to other e-commers sites owners, adding new features and expecting and be preparing for progect growing in future.
Also at this moment better to organize Agile communication in team with customer, setting userstories and tasks, decide, how long one spring should lasts and the format of each demo.
Creating separate chat channel (skype, slack etc.) into team for quick communications for common problems solving. Good solutions in case of different localizations of developers in others offices, citys and even countries.
Git repositore for commits, merging and code reviews.

<h4>Mockups preparations.</h4>

According to recuarements desiners should create few mockups for different devices and resolutions, because applications should look great and be functional not only in desktop. 
If it possible, create grafics and icons in swg format for better displaying it in retina/not retina view. In case of .png, .jpg creating double scaling images. 
Desiners also should know, how to create comfortable and using-frendly pages design and grids system for users. Choose one general slyle in elements, measures, fonts etc.
From mockups perspective this should be page with goods in card, with table and(or) list view. Must have sorting, filtering in defferent goods categories (type of good, prose,locations...);
Each good will have detail page with additive informations. Also in common and detaield view could persists rating, summary, customers reviews, in case of common page in short way. Also persist link into private customer cabinet with orders informations. Could be included block with chat for communications between user and seller in separate link.
After current goods choosing user will be provide to payment section. After all payment steps will be relocationg to success page.

<h4>Front-end development.</h4>

After creating and approving by customers mock up front-end developers staring their work for transforming in into real htm pages.
As is was decided before starting, developers will use react for dynamic html rendering with redux for data providing and actions.
For styles good to use sass or cssnext. For correct styles and js(jsx) compiling good to add webpack with it's loaders an servers running configurations into webpack.config.js
For module installing and communications will be installed node with npm and package.json, also could be yarn. 

For routing between page will be used react-redux-router. For providing store data with actions in react components - react-redux connect.

React jsx components will be connected with redux store. Each component will have personal reduser or scope with redusers. Will be creating file(s) with operations for communications with server (websokets, ajax requests)

Should be collected general scope of common features for all ar few pages like tables, modals, form validations, sliders ets. Possible to use ready libraries like boostrap, foundations or just separate plugins.
Creating documents with common code style for all developers, also for naming. Possibility to clone product with other theme styling.

<h5>Structure of Card react components.</h5>

<h6>Main(Home page) and Private user room.</h6>

Main page has table view component and list view component. Component for filtering, groupping, sorting, common for table and list.
If nessesary operations with server data, will be created reducer and operation fle for each component.  
When user clicking on item good detaled page opening. Detailed page has picture, good informations block, rating and reviews component, button for buying current item.
Then page with payments options will be opened. Better to communicate with already prepared system with paymens options which will have most popular payment ways (visa, mastercars, paypat etc).
After succesful payment user will be redirected to succes page. In case of order errors in rejections page.

<h6>Private user room.</h6>

Private user room will have table grid with current user orders informations component and messages feature which will have email communications and quick chat with customers.

<hr/>

For all communications with server data will be using .fetch() for ajax requests ans websockets (socket.io) for chat. Es-6 promises. For es-6 features will be adding babel with webpack loader settings.

All components should be covered with unit tests with Jest test library.

In this repository App structure was represented in card-app-structure.png.
<img src="https://github.com/effel/tech-test/blob/master/card-app-structure.png">

Interactions between data and react component showed on system-context-diagram.png 
<img src="https://github.com/effel/tech-test/blob/master/system-context-diagram.png">
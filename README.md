# 20 09 21 Team Development

[Git Branching](https://www.atlassian.com/git/tutorials/using-branches) | [Git Process](https://github.com/Kevin-CodeCrew/coding_concepts_sprint_3)

### Terminal Commands
```
git status : check which branch you are on and if there are any changes (tracked or un-tracked)
git branch <branch> : creates a new branch (you have not switched to this branch yet)
git checkout <branch> : switch to another branch

git add -A : add all changes made on your branch
git commit -m "meaningful commit message" : commit changes made on your branch
git push origin <branch> : push changes to your branch

create pull request : github will prompt you to review your change and create a pull request
merge pull request : review any conflicts and merge
git pull origin master : pull any remote changes to your local repository
```
### Classwork

*Divide the work among yourselves, create PRs often, and be prepared to speak to your process and final solution*

- Create a dot net mvc application with required packages
- Create and update a .gitignore file using `dotnet new gitignore` 
- Define a product model with properties product id, product name, product price, and product quantity
- Define a db context and add product model as db set
- Define a product controller with endpoints to view all products, render a form to create a new product, and add a product to the database
- Define views to display all products and to display a form for adding a new product
- Update landing page to route to view all products
- Update navigation bar with links to view all products and add a product
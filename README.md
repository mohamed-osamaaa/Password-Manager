

https://github.com/user-attachments/assets/f4bff9fc-a448-4595-a04b-1ef0ff4cc6f6




```markdown
# Password Manager

A simple password manager that allows you to list, retrieve, delete, and manage passwords. The passwords are stored in a text file with simulated encryption to demonstrate a basic approach to password management.

## Features

- List all saved passwords.
- Add or change a password for a specific website/app.
- Retrieve a password for a specific website/app.
- Delete a password for a specific website/app.

## Installation

To use the Password Manager, simply clone this repository and build it using Visual Studio or another C# development environment.

```bash
git clone https://github.com/mohamed-osamaaa/Password-Manager.git
cd Password-Manager
```

After cloning the repository, open the solution file (`Password-Manager.sln`) in your IDE and run the program.

## Usage

Upon running the program, you will be prompted with a menu where you can choose from the following options:

1. **List all passwords**: View all stored passwords.
2. **Add/Change password**: Add a new password or change an existing password.
3. **Get password**: Retrieve the password for a specific website/app.
4. **Delete password**: Delete the password for a specific website/app.

The passwords will be stored in a text file called `passwords.txt`, and they are encrypted before being saved to simulate basic encryption for security.

### Example

```plaintext
Please select an option:
1. List all passwords
2. Add/Change password
3. Get password
4. Delete password
```

## Encryption

The passwords are encrypted and decrypted using a simple encryption utility. This is not intended for production use, but demonstrates basic encryption for the sake of this project.

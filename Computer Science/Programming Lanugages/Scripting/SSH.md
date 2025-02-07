# Secure Shell (SSH) Configuration

Instead of `ssh -i ~/.ssh/mykey.pem -p 2222 user@remote_host`

Configure ~/.ssh/config file to use the key and port for the remote host.

```bash
Host alias
    HostName remote_host
    User user
    Port 2222
    IdentityFile ~/.ssh/mykey.pem
```

Now you can use `ssh alias` to connect to the remote host.
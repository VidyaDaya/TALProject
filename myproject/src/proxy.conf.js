const PROXY_CONFIG = [
  {
    context: [
      "/insurancepremium",
    ],
    target: "https://localhost:7268",
    secure: false
  }
]

module.exports = PROXY_CONFIG;

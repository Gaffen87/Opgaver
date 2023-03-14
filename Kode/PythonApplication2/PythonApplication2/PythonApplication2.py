import yfinance as yf

abbv = yf.ticker("ABBV")

print(abbv.fastinfo)



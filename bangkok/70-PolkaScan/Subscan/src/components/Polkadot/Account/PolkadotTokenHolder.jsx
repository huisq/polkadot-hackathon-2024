
import React, { useState } from "react";
import axios from 'axios';

function PolkadotTokenHolder() {
  const [tokenHolders, setTokenHolders] = useState(null);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState(null);
  const [token, setToken] = useState(""); // State to hold user input for the token

  const fetchTokenHolders = () => {
    if (!token) {
      setError("Please enter a token");
      return;
    }

    setLoading(true);
    setError(null);

    const data = JSON.stringify({
      "included_zero_balance": true,
      "max_balance": 0,
      "min_balance": 0,
      "order": "desc",
      "order_field": "balance",
      "page": 0,
      "row": 10,
      "token": token,     // Use the inputted token
      "unique_id": token.toLowerCase() // Convert token to lowercase for unique ID
    });

    const config = {
      method: 'post',
      url: 'https://polkadot.api.subscan.io/api/scan/token/holders',
      headers: { 
        'User-Agent': 'Apidog/1.0.0 (https://apidog.com)', 
        'Content-Type': 'application/json',
        'Authorization': 'Bearer 311e618de4bc4a6687fcbe8f1e8c910f' 
      },
      data: data
    };

    axios(config)
      .then(function (response) {
        if (response.data.code === 0) {
          setTokenHolders(response.data.data.list);
        } else {
          throw new Error(response.data.message);
        }
        setLoading(false);
      })
      .catch(function (error) {
        setError('Failed to fetch token holders');
        setLoading(false);
      });
  };

  return (
    <div className="p-5">
      <h2 className="text-2xl font-bold mb-4 text-pink-500">Polkadot Token Holders</h2>

      {/* Input field to enter the token */}
      <input
        type="text"
        placeholder="Enter token symbol (e.g., DOT)"
        value={token}
        onChange={(e) => setToken(e.target.value)}
        className="mb-4 p-2 border border-black bg-black text-white rounded-md w-full"
      />

      {/* Fetch Token Holders Button */}
      <button 
        onClick={fetchTokenHolders} 
        className="px-4 py-2 bg-black text-white rounded-md mt-2"
      >
        Fetch Token Holders
      </button>

      {/* Display loading, error, or data */}
      {loading && <p className="mt-4 text-black">Loading...</p>}
      {error && <p className="mt-4 text-red-600">{error}</p>}
      {tokenHolders && tokenHolders.length > 0 && (
        <div className="mt-4">
          <h3 className="text-xl font-semibold">Token Holders List</h3>
          <ul className="bg-gray-200 p-4 rounded-md">
            {tokenHolders.map((holder, index) => (
              <li key={index} className="border-b py-2">
                <p><strong>Address:</strong> {holder.address}</p>
                <p><strong>Balance:</strong> {holder.balance}</p>
                <p><strong>Count Extrinsic:</strong> {holder.count_extrinsic}</p>
              </li>
            ))}
          </ul>
        </div>
      )}
      {tokenHolders && tokenHolders.length === 0 && (
        <p className="mt-4">No token holders found.</p>
      )}
    </div>
  );
}

export default PolkadotTokenHolder;
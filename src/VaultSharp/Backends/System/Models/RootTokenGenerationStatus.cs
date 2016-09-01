﻿using Newtonsoft.Json;

namespace VaultSharp.Backends.System.Models
{
    /// <summary>
    /// Represents the configuration and progress of the root token generation attempt.
    /// </summary>
    public class RootTokenGenerationStatus
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RootTokenGenerationProgress"/> is started.
        /// </summary>
        /// <value>
        ///   <c>true</c> if started; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("started")]
        public bool Started { get; set; }

        /// <summary>
        /// Gets or sets the nonce for the current root token generation.
        /// </summary>
        /// <value>
        /// The nonce.
        /// </value>
        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or sets the number of unseal keys provided for this root token generation.
        /// </summary>
        /// <value>
        /// The progress.
        /// </value>
        [JsonProperty("progress")]
        public int UnsealKeysProvided { get; set; }

        /// <summary>
        /// Gets or sets the required number of unseal keys required to 
        /// complete the root token generation.
        /// </summary>
        /// <value>
        /// The required unseal keys.
        /// </value>
        [JsonProperty("required")]
        public int RequiredUnsealKeys { get; set; }

        /// <summary>
        /// Gets or sets the PGP finger print if 
        /// a PGP key is being used to encrypt the final root token.
        /// </summary>
        /// <value>
        /// The PGP finger prints.
        /// </value>
        [JsonProperty("pgp_fingerprint")]
        public string PGPFingerPrint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether 
        /// this root token generation is complete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if complete; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("complete")]
        public bool Complete { get; set; }
    }
}